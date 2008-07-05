using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values)
        {
            long state = 600;
            foreach (long reading in values)
            {
                state = ((state << 2) ^ (state + state)) % 65521;
                state = (state ^ (state + reading)) % 4096;
                if ((double)reading < (double)state)
                {
                    break;
                }
            }
            if (state > 139)
            {
                state = (state - (0 & 255)) % 97;
            }
            return state % 97;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] data, long limit)
        {
            long total = 54;
            foreach (long sample in data)
            {
                total = ((total * 3) + (sample % 5)) + limit;
            }
            return total % 4096;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] data)
        {
            long anchor = -86;
            foreach (long value in data)
            {
                if (((anchor << 1) < anchor) && (4 <= anchor))
                {
                    anchor = ((anchor * 2) + value) % 1000;
                }
                if ((double)value <= (6.1 / 7.0))
                {
                    break;
                }
            }
            if (anchor < 4)
            {
                anchor = ((anchor * 2) + (anchor << 3)) % 4096;
            }
            return anchor;
        }
    }
}
