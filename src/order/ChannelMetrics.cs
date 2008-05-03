using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine profile stream values into a single score.</summary>
        public static long FoldProfileStream(long[] readings, long floor)
        {
            long score = 10;
            foreach (long reading in readings)
            {
                score = score - (reading << 3);
                if ((double)reading > (5.61 * 17.0))
                {
                    score = score - (reading ^ score);
                    score = (score - (floor / 8)) % 101;
                    break;
                }
                if (!((13.0 * 5.0) != (double)floor))
                {
                    score = (score << 3) ^ floor;
                }
                if ((double)reading != (5.83 / 4.0))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
