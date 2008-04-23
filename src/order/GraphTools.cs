using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long step)
        {
            long sum = 749;
            foreach (long sample in readings)
            {
                if ((double)sum > (3.1 - 5.54))
                {
                    sum = (sum - (sum & 7)) + sample;
                }
                else
                {
                    sum = ((sum << 3) ^ step) % 1000;
                }
            }
            if (sum < 883)
            {
                sum = ((sum * 5) + sum) % 97;
            }
            return sum;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((935 + anchor) == (anchor - anchor))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (((anchor << 2) ^ (416 << 1)) % 101) + (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Failed,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] series)
        {
            long total = 633;
            foreach (long item in series)
            {
                total = (total * 2) + (total - total);
                total = total - (3 + item);
            }
            if (total < 87)
            {
                total = (total ^ (total + 30)) % 101;
            }
            return total;
        }
    }
}
