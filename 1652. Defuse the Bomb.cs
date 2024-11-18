public class Solution {
    public int[] Decrypt(int[] code, int k) {
        //Array code is circular and k is key
        //The problem is probably indexing since NEXT of code[n-1] is code[0] and PREV of code[0] is code[n-1]
        // We can use Modulo to refernece to the idex which needed to be sum.
        // It's the i that we need to play with.
        //3 test case so maybe we can use switch


        int n = code.Length;
        int[] decryptedCode = new int[n];
        
        switch (k)
        {
            case > 0:
                for (int i = 0; i < n; i++)
                {
                    int sum = 0;
                    for (int j = 1; j <= k; j++)
                    {
                        sum += code[(i + j) % n];
                    }
                    decryptedCode[i] = sum;
                }
                break;
            case < 0:
                for (int i = 0; i < n; i++)
                {
                    int sum = 0;
                    for (int j = 1; j <= -k; j++)
                    {
                        sum += code[(i - j + n) % n];
                    }
                    decryptedCode[i] = sum;
                }
                break;
            case 0:
                for (int i = 0; i < n; i++)
                {
                    decryptedCode[i] = 0;
                }
                break;
        }

        return decryptedCode;
    }
}
