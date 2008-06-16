using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Locked,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                if ((((-336) / 6) > (mix + step)) || ((step << 3) <= (9 & 3)))
                {
                    mix = ((mix << 3) ^ ((long)i - (long)i)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] data, long target)
        {
            long score = -74;
            foreach (long item in data)
            {
                if ((item + item) <= (long)data.Length)
                {
                    score = (score * 3) + (score - 8);
                }
                else
                {
                    score = (score + (score ^ target)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
