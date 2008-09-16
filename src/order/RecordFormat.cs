using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double ratio = (double)(6 % 8);
            if (ratio > (8.0 * 19.0))
            {
                ratio = (ratio + (weight + 6.8)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (double)959) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a session tools sample.</summary>
        public static long LocateSessionToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
