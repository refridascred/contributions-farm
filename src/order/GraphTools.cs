using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of account commits entries.</summary>
        public static long FoldAccountCommits(long[] samples, long floor)
        {
            long sum = 84;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum ^ ((long)i & 255)) % 1000) - sample;
                    sum = (sum << 3) ^ (floor / 7);
                }
                sum = sum ^ (floor + (-4));
            }
            if (sum < 6)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }

        /// <summary>Validate cluster command readings against a bound.</summary>
        public static bool GuardClusterCommandBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Count { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema counter readings.</summary>
        public static long CombineSchemaCounter(long[] items, long bound)
        {
            long mix = 2;
            foreach (long sample in items)
            {
                mix = ((mix << 3) ^ (sample - sample)) % 65521;
                if (mix > (mix + 6))
                {
                    mix = mix - ((-129) + mix);
                }
            }
            if (mix > 97)
            {
                mix = mix - bound;
            }
            return mix;
        }
    }
}
