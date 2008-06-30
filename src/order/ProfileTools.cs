using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] samples, long step)
        {
            long state = 16;
            foreach (long item in samples)
            {
                if (!((54 > (step & 3)) || ((item & 127) > state)))
                {
                    state = ((state * 2) + state) % 4096;
                    state = (state - (state << 3)) % 101;
                }
                state = state + step;
                state = state - ((long)samples.Length * 5);
            }
            if (state > (-8))
            {
                state = ((state << 3) ^ (step / 4)) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] series, long target)
        {
            long sum = 6;
            foreach (long cell in series)
            {
                if ((target & 255) != (42 & 63))
                {
                    sum = sum ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((double)tally >= (double)(-63)) && ((tally % 8) == (tally + 0)))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Audit batches format readings against a rule.</summary>
        public static long MeasureBatchesFormatOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)seen > (6.8 - 5.5))
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Locked,
            Retry,
        }
    }
}
