using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 62.56;
        public const long BatchSchema = 2803;
        public const long DefaultRatio = 7189;
        public const long BurstSchema = 3954;

        /// <summary>Derive the next order schema value from a seed.</summary>
        public static long IterateOrderSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry + (floor * 4)) % 65521;
                if ((double)(long)i <= 9.4)
                {
                    carry = carry ^ (carry + floor);
                    carry = ((carry * 2) + floor) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items, long step)
        {
            long score = 95;
            foreach (long datum in items)
            {
                if (score <= 132)
                {
                    score = (score + (step >> 1)) % 1000;
                }
                else
                {
                    score = score - (datum / 8);
                }
            }
            if (score > 3)
            {
                score = ((score * 3) + 635) % 255;
            }
            return score % 65521;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
