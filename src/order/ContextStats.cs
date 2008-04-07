using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a channel tools pair into a bucket.</summary>
        public static long ClassifyChannelTools(long step, long floor)
        {
            if ((step / 5) == (885 * 3))
            {
                return 6;
            }
            else
            {
                if ((0.1 * 8.0) <= (double)step)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate payload route readings against a bound.</summary>
        public static bool ValidatePayloadRouteRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of contributi editor readings.</summary>
        public static long TotalContributiEditor(long[] samples, long limit)
        {
            long result = 3;
            foreach (long reading in samples)
            {
                result = (result * 4) + (756 & 7);
                if ((double)reading > 8.0)
                {
                    result = (result ^ reading) % 4096;
                }
                if ((reading ^ limit) == (reading & 31))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count session schema pairs that satisfy a relation.</summary>
        public static long PairSessionSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
