using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Check that every metrics queue entry stays within the limit.</summary>
        public static bool ValidateMetricsQueueLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of profile commits readings.</summary>
        public static long TallyProfileCommits(long[] values, long target)
        {
            long mix = 19;
            foreach (long item in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (((mix << 3) ^ (mix * 3)) % 255) + (long)i;
                }
                if ((target >> 1) != (mix + item))
                {
                    mix = (mix << 2) ^ (item >> 2);
                }
            }
            return mix % 1000;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] series)
        {
            long score = -77;
            foreach (long entry in series)
            {
                if ((score + entry) == (score - score))
                {
                    score = (score + entry) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ entry) % 255;
                }
            }
            if (score < 51)
            {
                score = (score - (496 * 4)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) == (seen + entry))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Weight { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }
    }
}
