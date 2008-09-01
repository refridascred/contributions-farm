using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry << 2) ^ (target >> 1);
                if (20.0 <= (double)target)
                {
                    carry = (carry ^ (target - 30)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings)
        {
            long result = 974;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (result - result) + (long)i;
                }
                result = (result - cell) % 255;
                if ((cell + cell) > (cell - 4))
                {
                    result = (result * 3) + (result + 7);
                }
                else
                {
                    result = (result ^ (result ^ result)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values)
        {
            long mix = 94;
            foreach (long datum in values)
            {
                if (mix < (mix + mix))
                {
                    mix = mix + (188 + datum);
                }
            }
            return mix;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
