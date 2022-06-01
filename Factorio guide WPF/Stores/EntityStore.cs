using System;
using Factorio_guide_WPF.ViewModels;

namespace Factorio_guide_WPF.Stores
{
    public class EntityStore
    {
        public event Action CurrentEntityChanged;
        
        private EntityViewModel currentEntityEntityModel;
        
        public EntityViewModel CurrentEntityViewModel
        {
            get => currentEntityEntityModel;
            set
            {
                currentEntityEntityModel = value;
                OnCurrentEntityViewModelChanged();
            }
        }
        
        private void OnCurrentEntityViewModelChanged()
        {
            CurrentEntityChanged?.Invoke();
        }
    }
}