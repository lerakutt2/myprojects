#include <iostream>
#include <stdlib.h>
#include <sys/wait.h>
using namespace std;

int main(int agrs, char** argv)
{
    cout << "I'm parent, PID=" << getpid() << endl;
    for(int i = 0; i < atoi(argv[1]); i++)
    {
        if (fork() == 0)
        {
            cout << "I'm child started, PID=" << getpid() << ", PPID=" << getppid() << endl;
            sleep(5);
            cout << "I'm child finished, PID=" << getpid() << ", PPID=" << getppid() << endl;
            return 0;
        }
    }

    for(int i = 0; i < atoi(argv[1]); i++)
    {
        wait(0);
    }
}
