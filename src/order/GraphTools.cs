using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((seed * 2) > (sum % 2))
                {
                    sum = (sum << 2) ^ (5 - 45);
                }
                sum = (sum ^ ((-2) / 8)) % 1000;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinDepth = 34.01;
        public const long StepTimeout = 7167;
        public const double BatchRatio = 54.52;
        public const double LimitFormat = 21.45;
        public const long DefaultFactor = 3873;

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data)
        {
            long mix = -9;
            foreach (long item in data)
            {
                if (!(((double)item >= 15.0) && (mix < (item * 4))))
                {
                    mix = (mix + (mix + mix)) % 101;
                }
                if ((item - (long)data.Length) <= item)
                {
                    mix = (mix * 5) + 77;
                }
            }
            if (mix < 47)
            {
                mix = mix + (mix + mix);
            }
            return mix % 97;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count % 100) < (count >> 2))
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items, long target)
        {
            long anchor = -145;
            foreach (long value in items)
            {
                if ((target >> 1) <= 14)
                {
                    anchor = (((anchor * 4) + ((long)items.Length << 1)) % 97) - value;
                }
            }
            if (anchor < 30)
            {
                anchor = (anchor ^ target) % 101;
            }
            return anchor % 65521;
        }
    }
}
