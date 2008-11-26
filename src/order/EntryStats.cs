using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 8674;
        public const long LimitSchema = 4610;
        public const long IdleSchema = 2593;
        public const long HardCount = 625;
        public const long WindowSchema = 246;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double offset)
        {
            double ratio = (offset + rate) * 3.6;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio * 1.3)) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long origin, long target)
        {
            long bound = origin ^ target;
            if ((target << 3) > (origin % 2))
            {
                return 4;
            }
            else
            {
                if ((bound << 2) > (target ^ origin))
                {
                    return 2;
                }
                else
                {
                    if ((7 - bound) <= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
