using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload graph entry stays within the limit.</summary>
        public static bool ValidatePayloadGraphLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of tools format readings.</summary>
        public static long MatchToolsFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every tools schema entry stays within the limit.</summary>
        public static bool CheckToolsSchemaLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema payload readings.</summary>
        public static long DigestSchemaPayload(long[] data, long target)
        {
            long state = 0;
            foreach (long item in data)
            {
                state = (((state << 2) ^ state) % 65521) - item;
                state = state - (target & 63);
            }
            return state;
        }
    }
}
