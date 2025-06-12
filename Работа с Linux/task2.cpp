#include <iostream>
#include <stdlib.h>
#include <sys/wait.h>
#include <sys/times.h>
#include <sys/time.h>

using namespace std;

void bubble (int * v, int size);
void shell (int * v, int size);
void quicks (int * v, int size);

int main(int argc, char** argv)
{

    int n = atoi(argv[1]);
    int arr[n];
    for (int j = 0; j < n; j++)
    {
        arr[j] = rand() / 100000;

    }

    if (fork() == 0)
    {
        clock_t t_start = clock();
        cout << "bubble started" << endl;
        bubble(arr, n);
        cout << "bubble finished. time: " << (float) (clock() - t_start) / 1000 << endl;
        exit(0);

    }

    if (fork() == 0)
    {
        clock_t t_start = clock();
        cout << "quicksort started" << endl;
        quicks(arr, n);
        cout << "quicksort finished. time: " << (float) (clock() - t_start) / 1000 << endl;
        exit(0);
    }

    if (fork() == 0)
    {
        clock_t t_start = clock();
        cout << "shell started" << endl;
        shell(arr, 0);
        cout << "shell finished. time: " << (float) (clock() - t_start) / 1000 << endl;
        exit(0);
    }
    wait(0);
    wait(0);
    wait(0);
}

//************************** Bubble Sort
void bubble (int * v, int size) {
    for (int i=0; i<size; i++){
        for (int j=0; j<size-1; j++){
            if (v[j]>v[j+1]){
                int tmp = v[j];
                v[j] = v[j+1];
                v[j+1] = tmp;
            }
        }
    }
}

//************************** Shell Sort
void shell (int * v, int size) {
    int s=0;
    int j=0;
    do
    {
        s = 3*s+1;
    } while (s<=size);
    do {
        s = (s-1) / 3 + 1;
        for (int i=0; i<size; i++){
            j=i-s;
            int tmp = v[j+s];
            while (j >= 0 && tmp < v[j])  {
                v[j+s] = v[j];
                j -= s;
            }
            v[j+s] = tmp;
        }
    }while (s!=1);
}

//************************** Quick Sort
void qs (int * v, int low, int high) {
    int tmp=0;
    int  l = low;
    int r = high;
    int m = v[(l+r) / 2];
    do {
        while (v[l]<m) l++;
        while (v[r]>m) r--;
        if (l<=r){
            tmp = v[l];
            v[l] = v[r];
            v[r] = tmp;
            l++;
            r--;
        }
    } while (l<r);
    if (l<high) qs(v, l, high);
    if (r>low) qs(v,low, r);
}

void quicks (int * v, int size){
    qs (v, 0, size - 1);
}

