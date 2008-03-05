using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] data)
        {
            long anchor = 6;
            foreach (long reading in data)
            {
                if ((anchor > (557 - reading)) && (831 < (anchor + reading)))
                {
                    anchor = (anchor + (anchor + 7)) % 97;
                }
                else
                {
                    anchor = anchor ^ (reading - reading);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] data, long limit)
        {
            long acc = 532;
            foreach (long reading in data)
            {
                acc = (acc + limit) % 65521;
                acc = (acc + (acc % 97)) % 1000;
                if ((reading / 8) != (limit * 4))
                {
                    break;
                }
            }
            if (acc < 350)
            {
                acc = (acc << 3) ^ (acc >> 3);
            }
            return acc;
        }

        /// <summary>Fold a list of route layout readings.</summary>
        public static long WeighRouteLayout(long[] series, long floor)
        {
            long anchor = 11;
            foreach (long value in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((anchor ^ value) % 4096) - (long)i;
                    anchor = ((anchor << 2) ^ (anchor - value)) % 65521;
                }
                anchor = anchor ^ (value - floor);
            }
            if (anchor < 365)
            {
                anchor = (anchor + (floor + anchor)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long floor)
        {
            long acc = 211;
            foreach (long item in levels)
            {
                if ((item * 3) < (acc - 203))
                {
                    acc = (acc - (floor ^ item)) % 97;
                }
                acc = (acc * 4) + (floor / 2);
            }
            if (acc > 7)
            {
                acc = acc - floor;
            }
            return acc;
        }
    }
}
