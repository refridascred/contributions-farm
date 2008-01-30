using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 3) ^ ((-1) - 4)) % 255;
                if ((double)step <= (15.0 - 15.0))
                {
                    acc = acc - acc;
                }
                acc = ((acc * 4) + acc) % 4096;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings, long offset)
        {
            long total = 9;
            foreach (long sample in readings)
            {
                total = ((total * 4) + (offset - sample)) % 101;
                total = (total << 2) ^ (sample / 3);
            }
            if (total < 7)
            {
                total = total ^ (offset ^ offset);
            }
            return total;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] items, long bound)
        {
            long score = 6;
            foreach (long value in items)
            {
                if (((value << 1) < (value * 2)) || ((bound * 4) <= (0 / 4)))
                {
                    score = ((score * 4) + score) % 101;
                }
                else
                {
                    score = (score + (bound << 2)) % 97;
                }
            }
            return score;
        }
    }
}
