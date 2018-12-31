﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI.Legacy;

namespace ReactiveUI.Winforms
{
    /// <summary>
    /// IReactiveDerivedList represents a bindinglist whose contents will "follow" another
    /// collection; this method is useful for creating ViewModel collections
    /// that are automatically updated when the respective Model collection is updated.
    /// </summary>
    /// <typeparam name="T">The type.</typeparam>
    [Obsolete("ReactiveList is no longer supported. We suggest replacing it with DynamicData https://github.com/rolandpheasant/dynamicdata")]
    [SuppressMessage("Design", "CA1010: IList inheritors should inherit the generic form", Justification = "Legacy code.")]
    public interface IReactiveDerivedBindingList<T> : IReactiveDerivedList<T>, IBindingList
    {
    }
}