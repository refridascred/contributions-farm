using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long limit, long bound)
        {
            long prev = limit ^ bound;
            if ((bound + 146) > (-54))
            {
                return 6;
            }
            else
            {
                if ((((-123) >> 4) < prev) || ((prev - 0) == ((-152) / 5)))
                {
                    return 3;
                }
                else
                {
                    if (!((69 + limit) == (3 >> 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + bound) <= (8 - limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryInterval = 3435;
        public const long MinTimeout = 4469;
        public const long HardRatio = 4648;
        public const long MaxFactor = 4603;
        public const long WindowCommits = 8763;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] series)
        {
            long mix = 65;
            foreach (long item in series)
            {
                mix = (mix + (item % 2)) % 255;
                if (!((74 ^ 9) > item))
                {
                    long slot = mix;
                    mix = (mix + slot) % 1000;
                }
                if ((item - item) >= item)
                {
                    mix = ((mix << 2) ^ 72) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ item) % 97;
                }
            }
            return mix % 65521;
        }
    }
}
