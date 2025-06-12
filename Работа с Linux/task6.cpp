#include <iostream>
#include "string.h"
#include <sys/ipc.h>
#include <sys/shm.h>
#include <stdio.h>

using namespace std;

int main(int args, char** argv)
{
    int key = 402;
    if (strcmp(argv[1], "-c") == 0) // create
    {
        shmget(key, 100, IPC_CREAT | IPC_EXCL | 0666);
        perror("shmget");
    }
    else if (strcmp(argv[1], "-w") == 0 && args == 3) // write
    {
        int id = shmget(key, 0, 0);
        char* c = (char*) shmat(id, 0, 0);
        strcpy(c, argv[2]);
    }
    else if (strcmp(argv[1], "-r") == 0) // read
    {
        int id = shmget(key, 0, 0);
        char* c = (char*) shmat(id, 0, SHM_RDONLY);
        cout << c << endl;
    }
    else if (strcmp(argv[1], "-d") == 0) // delete
    {
        int id = shmget(key, 0, 0);
        shmctl(id, IPC_RMID, 0);
    }
    else
    {
        cout << "Неизвестный аргумент" << endl;
    }
}
