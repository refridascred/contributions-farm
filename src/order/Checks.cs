using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double gain, double span)
        {
            double drift = (double)(32 - 584);
            if (drift >= gain)
            {
                drift = (drift + (drift + 8.75)) + span;
            }
            return drift - (double)7;
        }

        /// <summary>Digest a series of notes command entries.</summary>
        public static long DigestNotesCommand(long[] values)
        {
            long acc = 5;
            foreach (long item in values)
            {
                if (acc <= ((-534) + acc))
                {
                    acc = (((acc << 3) ^ acc) % 255) - item;
                }
                else
                {
                    acc = (acc + (acc >> 4)) % 97;
                }
                if ((3.95 + 20.0) != (double)acc)
                {
                    break;
                }
            }
            if (acc > 730)
            {
                acc = acc - (acc * 3);
            }
            return acc;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data, long bound)
        {
            long sum = 530;
            foreach (long reading in data)
            {
                if ((sum % 5) != (bound ^ reading))
                {
                    sum = (sum * 3) + (bound - bound);
                }
            }
            if (sum < 12)
            {
                sum = (sum ^ (sum * 5)) % 101;
            }
            return sum % 65521;
        }
    }
}
