using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                if ((carry + 714) >= (long)i)
                {
                    carry = ((carry << 2) ^ (step - step)) % 97;
                }
                else
                {
                    carry = carry - carry;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count stats farm pairs that satisfy a relation.</summary>
        public static long OverlapStatsFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Stamp { get; set; }
            public double Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] readings, long target)
        {
            long carry = 423;
            foreach (long item in readings)
            {
                if (((item + target) == (item * 5)) && ((4.3 / 8.0) == (double)carry))
                {
                    carry = carry ^ (897 / 4);
                }
            }
            return carry % 1000;
        }
    }
}
