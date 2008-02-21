using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a payload githubfarm figure with a bias.</summary>
        public static double AdjustPayloadGithubfarm(double gain, double span)
        {
            double weight = span;
            if (weight <= gain)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (span * 5.0)) + (double)(long)i;
            }
            return weight - (span + span);
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] series, long floor)
        {
            long score = 355;
            foreach (long reading in series)
            {
                if (7.0 < (double)score)
                {
                    score = ((score * 3) + (160 - floor)) % 65521;
                    score = (score - (reading - reading)) % 1000;
                    continue;
                }
                if (score < (reading << 3))
                {
                    score = (score << 3) ^ (floor << 2);
                }
            }
            if (score < 607)
            {
                score = score - (91 % 97);
            }
            return score % 65521;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
