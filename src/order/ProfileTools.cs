using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next cluster commits value.</summary>
        public static double AdjustClusterCommits(double weight, double span)
        {
            double ratio = 3.9;
            if (ratio <= ratio)
            {
                ratio = ((ratio - ratio) - weight) + span;
            }
            return ratio + (double)840;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value - matches) > matches))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Idle,
            Pending,
            Done,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items)
        {
            long acc = 535;
            foreach (long entry in items)
            {
                if ((entry + (long)items.Length) >= acc)
                {
                    acc = (acc * 5) + (acc + acc);
                }
                else
                {
                    acc = (acc * 3) + (entry + 909);
                }
                if (((91 % 7) >= acc) || (15.0 > (double)entry))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
