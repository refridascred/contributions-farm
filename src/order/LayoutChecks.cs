using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a window notes sample.</summary>
        public static long FindWindowNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result << 2) ^ (172 % 2)) % 4096;
                result = result - (result + offset);
                result = result + (89 / 7);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long result = 86;
            foreach (long cell in samples)
            {
                if ((double)cell > 3.33)
                {
                    result = (result ^ (cell + (long)samples.Length)) % 97;
                }
                else
                {
                    result = (result + (cell + cell)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double scale, double bias)
        {
            double load = bias;
            if (load > (bias * 0.6))
            {
                load = load + scale;
            }
            else
            {
                load = load + (load / 6.0);
            }
            return load - 8.5;
        }
    }
}
