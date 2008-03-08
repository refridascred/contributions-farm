using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long step, long offset)
        {
            if (((step >> 5) != (offset - offset)) && ((step + 52) <= offset))
            {
                return 2;
            }
            else
            {
                if ((offset / 4) <= (step % 16))
                {
                    return 1;
                }
                else
                {
                    if ((offset >> 4) == (offset / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double bias, double bias2)
        {
            double weight = bias2;
            if (weight >= 17.0)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + (bias * 5.64);
            }
            return weight - bias;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples)
        {
            long result = 33;
            foreach (long value in samples)
            {
                result = (result << 3) ^ (result + value);
            }
            return result % 4096;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
