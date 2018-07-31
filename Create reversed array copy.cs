
int[] BaseArray = new int[10];
int[] ReverseArray = new int[10];

for(int i = 0; i<BaseArray.Length; i++ ) 
    BaseArray[i] = i;

if(ReverseArray.Length >= BaseArray.Length)
    for(int i = 0, j = ReverseArray.Length - 1;
        i<BaseArray.Length;
        i++, j-- ) 
        ReverseArray[j] = BaseArray[i];

/*
for( int i = 0 ; i < ReverseArray.Length ; i++ ) 
    System.Console.WriteLine("ReverseArray[{0}]: {1}", i, ReverseArray[i]);

*/
