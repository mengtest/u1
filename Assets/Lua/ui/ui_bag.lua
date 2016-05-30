local ui_bag = class(ui_session)

function ui_bag.show(args)
    local sd = ui_session_data(ui_session_type.POPUP, "Bag", "BagWin", true)
    local ui_manager = fw_facade:instance():get_mgr(mgr_name.UI_MGR)
    if ui_manager ~= nil then
        ui_manager:instance():show_popup(ui_bag(sd), true, args)
    end
end

function ui_bag.close()
    local ui_manager = fw_facade:instance():get_mgr(mgr_name.UI_MGR)
    if ui_manager ~= nil then
        ui_manager:instance():close_popup()
    end
end

function ui_bag:init(sessionData)
    self._base.init(self, sessionData)
    self.session_id = ui_session_id.UI_MESSAGEBOX
end

function ui_bag:reset_window(args)
  
end

return ui_bag