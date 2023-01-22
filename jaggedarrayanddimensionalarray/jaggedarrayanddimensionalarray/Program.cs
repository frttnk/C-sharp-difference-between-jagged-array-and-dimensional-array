
/*
// int[][] jaggedArray = new int[3 arrays][one dimension]
int[][] jaggedArray = new int[3][]
{
    new int[]{1,2,3},
    new int[]{3,4,5},
    new int[]{6,7,8},
};


for (int i = 0; i < jaggedArray.Length; i++)// access the array part
{
    for (int k = 0; k < jaggedArray[i].Length; k++)// access the dimension part
    {
        Console.Write(jaggedArray[i][k] + " ");
    }
    Console.WriteLine();
}


int[][][] jaggedArray2 = new int[2][][]
{
    new int[1][]
    {
        new int[5]{1,2,3,4,5}
    },
    new int [2][]
    {
        new int[3]{1,2,3},
        new int[4]{1,2,3,4}
    }
};

for (int i = 0; i < jaggedArray2.Length; i++)
{
    for (int k = 0; k < jaggedArray2[i].Length; k++)
    {
        for (int j = 0; j < jaggedArray2[i][k].Length; j++)
        {
            Console.Write(jaggedArray2[i][k][j] + " ");
        }
        Console.WriteLine();
    }
}*/




int[,] multiArray = new int[1, 3]
{
    {1,2,3}, // one row and three columns
};

int[,] multiArray2 = new int[2, 5]
{
    {1,2,3,4,5 },
    {6,7,8,9,10 }
};

/*
var rankOfTheArray = multiArray.Rank; // to get number of dimension
Console.WriteLine(rankOfTheArray);
*/

/*
int lengthOfTheArray = multiArray2.Length; // row * column
Console.WriteLine(lengthOfTheArray);
*/

/*
int value = multiArray[0, 0]; // you can access an element of the multidimensional array by specifying a row and column
Console.WriteLine(value);
*/

/*
for (int i = 0; i < multiArray2.GetLength(0); i++) 
{
    for (int k = 0; k < multiArray2.GetLength(1); k++) 
    {
        Console.Write(multiArray2[i, k]+" ");
    }

    Console.WriteLine();
}
*/

int[,,] threeDimension = new int[3, 2, 5] // will contain 3 rows {2 rows and 5 columns}
{
    {
        {1,2,3,4,5},{6,7,8,9,10},
    },
    {
        {11,12,13,14,15},{16,17,18,19,20},
    },
    {
        {21,22,23,24,25},{26,27,28,29,10},
    },
};


for (int i = 0; i < threeDimension.GetLength(0); i++)
{
    for (int k = 0; k < threeDimension.GetLength(1); k++)
    {
        for (int j = 0; j < threeDimension.GetLength(2); j++)
        {
            Console.Write(threeDimension[i, k, j]+" ");
        }
        Console.WriteLine();

    }
    Console.WriteLine();
}