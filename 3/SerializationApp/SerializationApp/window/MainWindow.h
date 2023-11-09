#pragma once
#include <FL/Fl.H>
#include <FL/Fl_Window.H>
#include <FL/Fl_Button.H>
#include <FL/fl_message.H>

#include "../stdafx.h"

#ifdef __MAINWINDOW_H__
#define __MAINWINDOW_H__
#endif // __MAINWINDOW_H__


void btnCallback(Fl_Widget *widget, void *)
{
    fl_message("Hello World!");
}



