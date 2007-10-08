using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Apolloniax {
    static class DetailControlTypes {
        public static Collection<Type> ListTypes() {
            Collection<Type> values = new Collection<Type>();

            foreach (Type type in typeof(DetailControlTypes).Assembly.GetTypes()) {
                if (typeof(DetailControl).IsAssignableFrom(type) && type != typeof(DetailControl)) {
                    values.Add(type);
                }
            }

            return values;
        }
    }
}
