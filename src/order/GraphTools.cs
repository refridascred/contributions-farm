using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a notes report counter forward.</summary>
        public static long SeriesNotesReport(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = ((total << 3) ^ (step - 37)) % 97;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long bound, long target)
        {
            long step = bound + target;
            if ((bound / 3) <= (step ^ step))
            {
                return 3;
            }
            else
            {
                if ((73 >> 5) > (step - 953))
                {
                    return 5;
                }
                else
                {
                    if (!(9.55 > (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric format readings.</summary>
        public static long CompareMetricFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples)
        {
            long anchor = 6;
            foreach (long reading in samples)
            {
                if ((6 * 4) > (anchor + reading))
                {
                    anchor = (anchor - anchor) % 97;
                }
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor * 4) + (long)i) % 255;
                }
                if (((reading / 2) <= (reading * 2)) || ((double)anchor >= (8.63 - 5.9)))
                {
                    anchor = ((anchor << 2) ^ (anchor % 60)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Validate checks format readings against a bound.</summary>
        public static bool ValidateChecksFormatBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
