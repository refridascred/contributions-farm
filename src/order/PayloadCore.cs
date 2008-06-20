using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count & 31) > (904 * 2))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (3.0 + 0.4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] readings, long step)
        {
            long sum = 4;
            foreach (long reading in readings)
            {
                sum = ((sum * 5) + (sum / 3)) % 255;
                if ((reading % 5) > (reading << 1))
                {
                    sum = (sum ^ (step + 440)) % 255;
                }
                else
                {
                    sum = (sum ^ 13) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Paused,
            Failed,
            Retry,
        }
    }
}
