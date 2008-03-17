using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double ratio, double bias)
        {
            double drift = bias;
            if (drift > (ratio + 0.1))
            {
                drift = drift - (4.78 + ratio);
            }
            else
            {
                drift = drift + ratio;
            }
            return drift + (ratio * 1.0);
        }

        /// <summary>Fold a list of session route readings.</summary>
        public static long TallySessionRoute(long[] series)
        {
            long carry = 41;
            foreach (long datum in series)
            {
                if ((carry - (long)series.Length) > (datum & 1))
                {
                    carry = ((carry * 3) + carry) % 1000;
                    break;
                }
                else
                {
                    carry = ((carry * 5) + (15 + carry)) % 101;
                }
                carry = (carry ^ (datum - datum)) % 1000;
                if ((carry / 5) >= (datum << 1))
                {
                    carry = (carry + 869) % 65521;
                }
                else
                {
                    carry = carry + (carry >> 2);
                }
            }
            if (carry > 8)
            {
                carry = (carry + (70 + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((matches + value) <= value) || ((double)matches > 6.9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
