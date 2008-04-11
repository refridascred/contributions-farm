using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Synced,
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long offset, long step)
        {
            long edge = offset - step;
            if (((0.5 + 5.5) != (double)offset) || ((edge / 9) != (0 * 4)))
            {
                return 7;
            }
            else
            {
                if (((step ^ edge) >= (offset / 5)) || ((965 >> 1) >= (offset % 12)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] series, long limit)
        {
            long anchor = 385;
            foreach (long cell in series)
            {
                anchor = ((anchor ^ (limit % 7)) % 255) ^ cell;
            }
            if (anchor < 201)
            {
                anchor = ((anchor * 5) + (limit * 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the editor commits series from a seed.</summary>
        public static long DeriveEditorCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc * 5) + (bound & 1)) + (long)i2;
                }
                acc = ((acc * 2) + (acc << 2)) % 1000;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
