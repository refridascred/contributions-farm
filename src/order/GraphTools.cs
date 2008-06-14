using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a graph already reading.</summary>
        public static double ProjectGraphAlready(double scale, double span)
        {
            double load = scale;
            if (load < 0.86)
            {
                load = load + (3.2 * 1.0);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + 17.0) - (double)(long)i;
            }
            return load + (span + span);
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data)
        {
            long carry = 469;
            foreach (long item in data)
            {
                if (((double)item <= (double)carry) && ((item + 814) >= (carry / 3)))
                {
                    carry = (carry * 2) + item;
                }
                carry = (carry << 2) ^ (item ^ carry);
            }
            if (carry > (-40))
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Rank command channel input into a small class.</summary>
        public static long BucketCommandChannel(long limit, long offset)
        {
            long gap = limit - offset;
            if ((limit - offset) >= (6 + limit))
            {
                return 3;
            }
            else
            {
                if ((gap / 2) < (offset ^ limit))
                {
                    return 6;
                }
                else
                {
                    if ((gap >> 2) != ((-954) - 68))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((gap ^ 588) == (32 - gap))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema commits values into a single score.</summary>
        public static long DigestSchemaCommits(long[] readings, long floor)
        {
            long total = 62;
            foreach (long value in readings)
            {
                if ((6.4 - 3.06) == (double)total)
                {
                    total = (total + 997) + value;
                    break;
                }
                total = (total ^ (floor >> 2)) % 255;
                if (!(floor > (floor - floor)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
