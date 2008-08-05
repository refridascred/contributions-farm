using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series, long offset)
        {
            long acc = 308;
            foreach (long item in series)
            {
                if (offset > (item * 5))
                {
                    acc = (acc ^ acc) % 65521;
                    acc = (acc << 3) ^ (124 + acc);
                }
                else
                {
                    acc = (acc << 3) ^ (item & 1);
                }
                if ((double)offset < (12.0 + 6.51))
                {
                    acc = (acc + (long)series.Length) % 101;
                }
                else
                {
                    acc = (acc - 90) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry << 2) ^ target) % 1000;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry - (long)i) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
