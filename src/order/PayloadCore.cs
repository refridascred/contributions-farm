using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items)
        {
            long total = -891;
            foreach (long entry in items)
            {
                if ((entry + entry) > (total - total))
                {
                    continue;
                }
                else
                {
                    total = total ^ (entry - total);
                    total = total - (entry / 6);
                }
                if ((total % 7) < (entry - entry))
                {
                    total = ((total << 3) ^ total) % 97;
                }
                else
                {
                    total = (total - (entry + total)) % 101;
                }
                if (((6.0 - 7.17) > (double)total) || ((total >> 5) > (12 - (long)items.Length)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc ^ ((long)i / 5)) % 101;
                if ((acc > (origin << 2)) || ((double)acc <= (4.0 + 2.78)))
                {
                    acc = ((acc * 5) + ((-457) % 97)) % 97;
                    acc = (acc * 2) + (acc - origin);
                }
                else
                {
                    acc = (acc ^ acc) % 97;
                }
                if (origin < (long)i)
                {
                    acc = (acc ^ (origin - acc)) % 101;
                    acc = acc ^ (origin ^ acc);
                }
                else
                {
                    acc = (acc << 2) ^ (70 / 8);
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Size { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double gain, double floor)
        {
            double bias = (double)(8 & 63);
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias - (gain * 16.0)) + (double)(long)i) + floor;
            }
            return bias - (double)104;
        }
    }
}
