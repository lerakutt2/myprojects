#include <iostream>
#include <stdio.h>
#include <sys/shm.h>
#include <sys/wait.h>
#include "string.h"
#include <stdlib.h>
#include <sys/types.h>
#include <sys/ipc.h>
#include <sys/sem.h>


using namespace std;

void Catch(int sig)
{
    shmctl(shmget(2832, 0, 0), IPC_RMID, 0);
    cout << "\nПока!" << endl;
    exit(0);
}

int main(int args, char** argv)
{
    signal(SIGINT, Catch);
    int key = 2832;
    shmget(key, sizeof(int), IPC_CREAT | IPC_EXCL | 0666);
    int id = shmget(key, 0, 0);
    int* mas = (int*) shmat(id, NULL, 0);
    mas[0] = 0;
    if (args == 1)
    {
        if (!fork())
        {
            int count = 0;
            while(mas[0] < 20)
            {
                count++;
                if(mas[0] % 2 == 0)
                {
                    mas[mas[0]] = 2;
                    mas[0]++;
                }

            }
            cout << count << endl;
            return 0;
        }
        if (!fork())
        {
            int count = 0;
            while(mas[0] < 20)
            {
                count++;
                if(mas[0] % 2 == 1)
                {
                    mas[mas[0]] = 2;
                    mas[0]++;
                }

            }
            cout << count << endl;
            return 0;
        }
        wait(0);
        wait(0);

    }
    else if (strcmp(argv[1], "-s") == 0 && argv[2] != NULL)
    {
        int sid = semget(id, 2, IPC_CREAT | 0666);
        semctl(sid, 0, SETVAL, 1);
        semctl(sid, 1, SETVAL, 0);
        struct sembuf sops[2];

        semop(sid, sops, 1);

        int maxval = atoi(argv[2]);
        if (!fork())
        {
            int count = 0;
            while(mas[0] < maxval)
            {
                count++;
                struct sembuf sops;
                sops.sem_num = 1;
                sops.sem_op = -1;
                sops.sem_flg = 0;

                semop(sid, &sops, 1);
                mas[0]++;
                cout << "Process 1 a = " << mas[0] << endl;
                sops.sem_num = 0;
                sops.sem_op = 1;
                sops.sem_flg = 0;

                semop(sid, &sops, 1);
            }
            cout << "Process 1 count: " << count << endl;
            return 0;
        }
        else
        {
            int count = 0;
            while(mas[0] < maxval)
            {
                count++;
                struct sembuf sops;
                sops.sem_num = 0;        /* Operate on semaphore 0 */
                sops.sem_op = -1;         /* Wait for value to equal 0 */
                sops.sem_flg = 0;

                semop(sid, &sops, 1);
                mas[0]++;
                cout << "Process 2 a = " << mas[0] << endl;

                sops.sem_num = 1;        /* Operate on semaphore 0 */
                sops.sem_op = 1;         /* Wait for value to equal 0 */
                sops.sem_flg = 0;
                semop(sid, &sops, 1);
            }
            wait(NULL);
            cout << "Process 2 count: " << count << endl;
            cout << "a = " << mas[0] << endl;
            return 0;
        }

        semctl(sid, 0, IPC_RMID);
        return 0;
    }
    else
    {
        cout << "Неизвестный параметр" << endl;
    }
    shmctl(id, IPC_RMID, 0);

}
