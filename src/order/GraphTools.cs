using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every metric format entry stays within the limit.</summary>
        public static bool VerifyMetricFormatRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first stream checks entry that matches the target.</summary>
        public static long LookupStreamChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] readings, long bound)
        {
            long state = 6;
            foreach (long reading in readings)
            {
                if ((bound ^ bound) >= (reading + state))
                {
                    state = state ^ (state / 4);
                }
            }
            if (state < 3)
            {
                state = state + (bound ^ state);
            }
            return state;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!((9.0 * 8.9) <= (double)state))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
