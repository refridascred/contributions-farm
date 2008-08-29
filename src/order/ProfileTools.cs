using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double load = ratio;
            if (load < bias)
            {
                load = load - (load - 4.72);
            }
            else
            {
                load = load + (double)(-849);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 0.7) + (double)(long)i;
            }
            return load + ratio;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate route report samples.</summary>
        public static long WeighRouteReport(long[] readings, long step)
        {
            long mix = -892;
            foreach (long sample in readings)
            {
                if ((11 % 16) < (186 - mix))
                {
                    mix = ((mix * 3) + step) % 65521;
                }
                else
                {
                    mix = (mix - (sample + mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
