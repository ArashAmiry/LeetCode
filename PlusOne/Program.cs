namespace PlusOne
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            bool carry = false;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }
                else if (digits[i] == 9 && carry)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] = 0;
                    carry = true;
                }
            }

            int[] newDigits = new int[digits.Length + 1];

            for (int i = 0; i < newDigits.Length; i++)
            {
                if (i == 0)
                {
                    newDigits[i] = 1;
                }
                else
                {
                    newDigits[i] = 0;
                }
            }

            return newDigits;

        }
    }
}
