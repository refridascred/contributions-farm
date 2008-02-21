using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next metrics githubfarm value.</summary>
        public static double ProjectMetricsGithubfarm(double weight, double bias)
        {
            double bias2 = bias - (1.12 / 4.0);
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - (5.5 - bias)) + (double)(long)i) + weight;
            }
            return bias2 + 3.26;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen & 3) <= seen)
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum <= ((long)samples.Length * 2))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
