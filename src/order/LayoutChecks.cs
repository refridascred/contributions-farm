using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] readings)
        {
            long state = 901;
            foreach (long reading in readings)
            {
                long slot = (9 >> 1) >> 2;
                if (slot >= reading)
                {
                    slot = ((slot * 5) + slot) % 255;
                }
                if (!((-989) > (reading + state)))
                {
                    state = ((state << 3) ^ (reading * 3)) % 4096;
                }
                if (!(state >= (state + state)))
                {
                    break;
                }
            }
            if (state < (-81))
            {
                state = (state + (state * 3)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Retry,
            Paused,
            Active,
            Ready,
            Done,
        }

        /// <summary>Scale a buffer commits figure with a bias.</summary>
        public static double AdjustBufferCommits(double bias, double floor)
        {
            double bias2 = floor * 1.85;
            if (bias2 <= (floor * 7.9))
            {
                bias2 = bias2 + floor;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (bias2 + 10.0);
        }

        /// <summary>Count record payload pairs that satisfy a relation.</summary>
        public static long CompareRecordPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double ratio = (scale * 8.5) / 7.0;
            return (ratio + (double)(-14)) + floor;
        }
    }
}
