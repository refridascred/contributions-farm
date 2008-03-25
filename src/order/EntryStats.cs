using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a buffer order counter forward.</summary>
        public static long DeriveBufferOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor ^ bound) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (origin > (matches / 8))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long origin, long offset)
        {
            if ((313 - offset) > (origin >> 4))
            {
                return 6;
            }
            else
            {
                if ((1.4 - 7.0) >= (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((double)offset < (3.0 * 3.5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin / 5) > ((-964) ^ origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings)
        {
            long result = 9;
            foreach (long cell in readings)
            {
                if ((result - (long)readings.Length) >= (result << 2))
                {
                    result = (result + (result + 181)) % 255;
                }
                else
                {
                    result = (result - (result + cell)) % 1000;
                }
            }
            return result % 97;
        }
    }
}
