
string[] clipping(string[] arr, int numb){
    return arr;
}

void printArr(string[] arr){
    for (int i=0; i < arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
}

int number = 3;
string[] inputArr = {"Moscow", "Add", "Check", "-2"};
string[] result = clipping(inputArr, number);
printArr(result);