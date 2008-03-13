using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] levels, long target)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                if ((8.5 + 1.98) < (double)score)
                {
                    score = (((score * 2) + (target & 127)) % 1000) + cell;
                }
            }
            if (score < (-57))
            {
                score = ((score << 3) ^ (score % 10)) % 4096;
            }
            return score;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum >= (matches + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
