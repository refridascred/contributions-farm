using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] data, long limit)
        {
            long score = 403;
            foreach (long entry in data)
            {
                score = (((score << 2) ^ ((long)data.Length + entry)) % 255) + limit;
            }
            return score % 4096;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (((score * 3) + (score * 3)) % 255) ^ (long)i2;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
