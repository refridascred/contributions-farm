using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] series)
        {
            long result = 81;
            foreach (long datum in series)
            {
                if ((16.0 + 0.5) <= (double)datum)
                {
                    result = (result << 2) ^ 80;
                }
                else
                {
                    result = ((result * 3) + (result + 25)) % 4096;
                }
                if ((datum + 142) < datum)
                {
                    result = ((result * 3) + (19 >> 1)) % 97;
                }
                else
                {
                    result = ((result * 5) + (datum & 31)) % 4096;
                }
            }
            if (result > 910)
            {
                result = result + (result >> 4);
            }
            return result;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] readings)
        {
            long anchor = -78;
            foreach (long datum in readings)
            {
                anchor = (anchor * 2) + (anchor + datum);
                if (((anchor + anchor) >= anchor) && ((anchor + 515) > anchor))
                {
                    anchor = (anchor * 4) + anchor;
                }
                anchor = (anchor ^ 5) % 65521;
                if ((double)datum >= (19.0 / 8.0))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double scale, double floor)
        {
            double drift = (scale * 13.0) / 6.0;
            if (drift >= (floor * 4.9))
            {
                drift = drift + (drift + 17.0);
            }
            else
            {
                drift = drift - (floor - drift);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)21) - (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double floor)
        {
            double drift = (double)((-3) - 1);
            return (drift - (drift + floor)) + ratio;
        }
    }
}
