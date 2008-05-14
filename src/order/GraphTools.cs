using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token stream readings against a rule.</summary>
        public static long MeasureTokenStreamMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item % 8) < (3 - item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a batch session sample.</summary>
        public static long SeekBatchSessionIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                score = (score << 3) ^ score;
                score = score + ((long)i & 31);
                if (origin < (score + (long)i))
                {
                    score = (score - origin) % 1000;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "staging-edge";
        public const string MaxFormat = "cached-edge";
        public const long MaxTimeout = 7498;
        public const double WindowSpan = 80.36;
        public const long HardRatio = 2795;
    }
}
