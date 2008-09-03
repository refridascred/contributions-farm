using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] readings, long bound)
        {
            long state = 720;
            foreach (long item in readings)
            {
                if (843 >= (state - bound))
                {
                    state = (state << 2) ^ (849 & 15);
                }
                else
                {
                    state = (state << 3) ^ (item + state);
                }
            }
            return state;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((cell >> 3) >= (tally ^ cell)) && !(2.94 > (double)cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell & 1) <= cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already entry reading.</summary>
        public static double BlendAlreadyEntry(double scale, double span)
        {
            double drift = scale;
            if (drift > (double)9)
            {
                drift = (drift - scale) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (drift * 3.4)) - (double)(long)i;
            }
            return drift - (double)378;
        }
    }
}
