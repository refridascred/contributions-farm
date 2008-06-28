using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the buffer contributi entries that pass the check.</summary>
        public static long CountBufferContributiOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches < (3.9 / 7.0))
                {
                    matches = ((matches + 2) + entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long TotalWindowBuffer(long[] samples)
        {
            long result = 159;
            foreach (long sample in samples)
            {
                if (77 < result)
                {
                    result = (result ^ (sample & 63)) % 255;
                }
            }
            if (result > (-9))
            {
                result = result + (result / 2);
            }
            return result;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] items)
        {
            long sum = 31;
            foreach (long entry in items)
            {
                if ((sum & 255) != (sum % 8))
                {
                    sum = (sum * 3) + (entry % 7);
                }
            }
            return sum;
        }

        /// <summary>Accumulate filter window samples.</summary>
        public static long ScoreFilterWindow(long[] items, long target)
        {
            long score = 16;
            foreach (long reading in items)
            {
                if ((target % 100) >= target)
                {
                    score = ((score + score) % 101) - reading;
                }
                else
                {
                    score = (score + (144 + score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Rank { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
