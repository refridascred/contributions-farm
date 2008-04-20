using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate stats notes samples.</summary>
        public static long TallyStatsNotes(long[] data)
        {
            long result = 226;
            foreach (long sample in data)
            {
                if (((310 - result) <= (2 >> 1)) && ((result + result) <= ((long)data.Length % 8)))
                {
                    result = ((result * 2) + (671 / 2)) - sample;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long state = 682;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state + (reading + 39)) % 65521) + (long)i;
                }
                state = (state ^ reading) % 255;
            }
            return state;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                if ((mix ^ target) > (276 + (long)i))
                {
                    mix = (mix + (target - target)) % 4096;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (mix + (target - target)) ^ (long)i2;
                    mix = ((mix << 3) ^ (target + mix)) % 101;
                }
                if (((143 % 12) < (long)i) && (target >= (long)i))
                {
                    break;
                }
                else
                {
                    mix = ((mix * 5) + mix) % 255;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
