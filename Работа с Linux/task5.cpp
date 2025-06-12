#include <iostream>
#include <sys/wait.h>
#include <string.h>
#include <stdio.h>
#include <cstring>
#include <sys/types.h>
#include <fcntl.h>
#include <stdlib.h>

using namespace std;

void Catch(int sig)
{
    cout << "\nПока!" << endl;
    exit(0);
}

int main() {
    signal(SIGINT, Catch);
    while(true) {
        cout << ">> ";
        char line[256];
        cin.getline(line, 256);
        if (strcmp(line, "e") == 0) { return 0; }
        char* mas[20];
        char* mas1[20];
        char filename[256];
        int token = 0;
        mas[token] = strtok(line, " ");
        bool redir = false;
        bool conv = false;

        while (mas[token] != NULL) {
            token++;
            mas[token] = strtok(NULL, " ");
        }

        for (int i = 0; i < token; i++)
        {
            if (strcmp(mas[i], ">") == 0)
            {
                strcpy(filename, mas[i+1]);
                redir = true;
                mas[i] = NULL;
            }
            else if (strcmp(mas[i], "|") == 0)
            {
                mas[i] = NULL;
                conv = true;
                for(int j = i; j < token; j++)
                {
                    mas1[j - i] = mas[j + 1];
                }
                break;
            }
        }

        if (strcmp(mas[0], "cd") == 0) {
            chdir(mas[1]);
        }
        else if (redir)
        {
            if (fork() == 0)
            {
                int fd;
                fd = open(filename, O_WRONLY | O_CREAT | O_TRUNC, 0644);

                if (fd < 0) {
                    cerr << "Can't open file";
                    return 0;
                }
                dup2(fd, 1);
                close(fd);
                execvp(mas[0], mas);
                cout << "ERROR" << endl;
                return 0;
            }
            wait(0);

        }
        else if (conv) {
            int fd[2];
            pipe(fd);

            if (fork() == 0)
            {
                dup2(fd[1], 1);
                close(fd[0]);
                close(fd[1]);
                execvp(mas[0], mas);
                cout << "ERROR" << endl;
                return 0;
            }
            if (fork() == 0) {
                dup2(fd[0], 0);
                close(fd[0]);
                close(fd[1]);
                execvp(mas1[0], mas1);
                cout << "ERROR" << endl;
                return 0;
            }
            close(fd[0]);
            close(fd[1]);
            wait(0);
            wait(0);
        }
        else {
            if (fork() == 0) {
                execvp(mas[0], mas);
                cout << "ERROR" << endl;
                return 0;
            }
            wait(0);
        }
    }
}
