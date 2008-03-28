using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                score = (score << 2) ^ (score + (long)i);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a entry metrics reading.</summary>
        public static double ScaleEntryMetrics(double weight, double floor)
        {
            double drift = (9.22 - floor) / 4.0;
            if (drift >= (floor + floor))
            {
                drift = (drift - 9.0) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (drift / 3.0);
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
