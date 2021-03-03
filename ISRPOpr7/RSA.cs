using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ISRPOpr7
{
    class RSA
    {
        public static byte[] Encrypt(byte[] message, int[] key)
        {
            if (key[1] == 1)
                throw new ArgumentException("Ключ некорректен");
            else
            {
                List<byte> result = new List<byte>();
                foreach (byte b in message)
                {
                    int c = 1;
                    for (int i = 0; i < key[0]; i++)
                    {
                        c = c * Convert.ToInt32(b.ToString()) % key[1];
                    }
                    result.Add(Convert.ToByte(c.ToString()));
                }
                return result.ToArray();
            }
        }

        public static byte[] Decrypt(byte[] message, int[] key)
        {
            if (key[1] == 1)
                throw new ArgumentException("Ключ некорректен");
            else
            {
                List<byte> result = new List<byte>();
                foreach (byte b in message)
                {
                    int c = 1;
                    for (int i = 0; i < key[0]; i++)
                    {
                        c = c * Convert.ToInt32(b.ToString()) % key[1];
                    }
                    result.Add(Convert.ToByte(c.ToString()));
                }
                return result.ToArray();
            }
        }

        public static List<int[]> GetKeys(int p, int q)
        {
            int module = p * q;
            int phi = (p - 1) * (q - 1);
            int exp = CalculateExp(phi);
            int d = CalculateD(exp, phi);
            
            return new List<int[]>() { new int[2] { exp, module }, new int[2] { d, module } };
        }

        private static int CalculateExp(int phi)
        {
            int exp = phi - 1;
            for (int i = 2; i <= phi; i++)
            {
                if ((phi % i == 0) && (exp % i == 0))
                {
                    exp--;
                    i = 2;
                }
            }

            return exp;
        }

        private static int CalculateD(int exp, int phi)
        {
            int d = 10;

            while (true)
            {
                if (d * exp % phi == 1)
                    break;
                else
                    d++;
            }

            return d;
        }
    }
}
