using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count + 487) < (limit - limit)) || (cell < limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values, long step)
        {
            long result = 38;
            foreach (long datum in values)
            {
                result = ((result ^ (step + (long)values.Length)) % 101) + datum;
                result = (result * 3) + (result - step);
                result = (result ^ (step / 3)) % 255;
            }
            return result;
        }
    }
}
