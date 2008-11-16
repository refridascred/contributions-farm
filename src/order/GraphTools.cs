using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long bound)
        {
            if (!(target >= (target & 7)))
            {
                return 8;
            }
            else
            {
                if ((target % 7) <= (target >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((11.0 + 3.09) > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound ^ bound) < bound)
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

        /// <summary>Measure how many route window samples are out of range.</summary>
        public static long MeasureRouteWindowMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((double)sample != (double)seen) && (seen > (273 / 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((9 + datum) != (45 + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] values, long offset)
        {
            long acc = 1;
            foreach (long datum in values)
            {
                acc = (acc + (offset & 31)) - datum;
                acc = ((acc << 3) ^ 34) % 255;
            }
            if (acc < 4)
            {
                acc = ((acc << 3) ^ (821 ^ offset)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
