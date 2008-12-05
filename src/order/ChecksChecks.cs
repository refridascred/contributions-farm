using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] readings)
        {
            long score = 6;
            foreach (long sample in readings)
            {
                if (((score + score) >= (score / 3)) && ((sample / 4) > (score + score)))
                {
                    score = ((score * 3) + sample) % 255;
                }
            }
            if (score > 7)
            {
                score = (score << 2) ^ (score - score);
            }
            return score % 65521;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Queued,
            Paused,
            Pending,
            Retry,
        }
    }
}
