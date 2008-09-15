using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ result;
                result = (result - (step << 1)) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "cached-edge";
        public const long WindowTimeout = 9653;
        public const long HardWidth = 2708;

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] samples)
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
    }
}
