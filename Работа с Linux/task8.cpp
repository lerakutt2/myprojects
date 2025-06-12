#include <iostream>
#include "string.h"
#include <sys/types.h>
#include <sys/ipc.h>
#include <sys/msg.h>
#include <sys/shm.h>
#include <stdio.h>
#include <stdlib.h>

using namespace std;

struct message
{
    long mtype;
    char mtext[1000];
};

int main(int args, char** argv)
{
    int key = 333;
    if (strcmp(argv[1], "-c") == 0) // create
    {
        msgget(key, IPC_CREAT|0666);
        perror("shmget");
    }
    else if (strcmp(argv[1], "-s") == 0 && args == 3) // send
    {
        message m;
        m.mtype = atoi(argv[2]);
        cin >> m.mtext;
        int id = msgget(key, 0);
        perror("msgget");
        msgsnd(id, &m, strlen(m.mtext), 0);
        perror("msgsnd");
//        int id = shmget(key, 0, 0);
//        char* c = (char*) shmat(id, 0, 0);
//        strcpy(c, argv[2]);
    }
    else if (strcmp(argv[1], "-r") == 0 && args == 3) // read
    {
        message m;
        int id = msgget(key, 0);
        msgrcv(id, &m, 1000, atoi(argv[2]), 0);
        cout << m.mtext << endl;
    }
    else if (strcmp(argv[1], "-d") == 0) // delete
    {
       int id = msgget(key, 0);
    }
    else
    {
        cout << "Неизвестный аргумент" << endl;
    }
}
