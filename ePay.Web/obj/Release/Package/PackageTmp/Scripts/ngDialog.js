/*! ng-dialog - v0.2.9 (https://github.com/likeastore/ngDialog) */ ! function (a, b) {
    "use strict";
    var c = b.module("ngDialog", []),
        d = b.element,
        e = b.isDefined,
        f = (document.body || document.documentElement).style,
        g = e(f.animation) || e(f.WebkitAnimation) || e(f.MozAnimation) || e(f.MsAnimation) || e(f.OAnimation),
        h = "animationend webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend",
        i = !1;
    c.provider("ngDialog", function () {
        var c = this.defaults = {
            className: "ngdialog-theme-default",
            plain: !1,
            showClose: !0,
            closeByDocument: !0, 
            closeByEscape: !0,
            appendTo: !1,
            name: "ngDialog"
        };
        this.setForceBodyReload = function (a) {
            i = a || !1
        };
        var e, f = 0,
            j = 0,
            k = {};
        this.$get = ["$document", "$templateCache", "$compile", "$q", "$http", "$rootScope", "$timeout", "$window", function (i, l, m, n, o, p, q, r) {
            var s = i.find("body");
            c.forceBodyReload && p.$on("$locationChangeSuccess", function () {
                s = i.find("body")
            });
            var t = {
                onDocumentKeydown: function (a) {
                    27 === a.keyCode && u.close()
                },
                setBodyPadding: function (a) {
                    var b = parseInt(s.css("padding-right") || 0, 10);
                    s.css("padding-right", b + a + "px"), s.data("ng-dialog-original-padding", b)
                },
                resetBodyPadding: function () {
                    var a = s.data("ng-dialog-original-padding");
                    a ? s.css("padding-right", a + "px") : s.css("padding-right", "")
                },
                closeDialog: function (b) {
                    var c = b.attr("id");
                    "undefined" != typeof a.Hammer ? a.Hammer(b[0]).off("tap", e) : b.unbind("click"), 1 === j && s.unbind("keydown"), b.hasClass("ngdialog-closing") || (j -= 1), g ? b.unbind(h).bind(h, function () {
                        b.scope().$destroy(), b.remove(), 0 === j && (s.removeClass("ngdialog-open"), t.resetBodyPadding())
                    }).addClass("ngdialog-closing") : (b.scope().$destroy(), b.remove(), 0 === j && (s.removeClass("ngdialog-open"), t.resetBodyPadding())), k[c] && (k[c].resolve({
                        id: c,
                        $dialog: b,
                        remainingDialogs: j
                    }), delete k[c]), p.$broadcast("ngDialog.closed", b)
                }
            },
                u = {
                    open: function (g) {
                        function h(a) {
                            return a ? b.isString(a) && v.plain ? a : l.get(a) || o.get(a, {
                                cache: !0
                            }) : "Empty template"
                        }
                        var i = this,
                            v = b.copy(c);
                        g = g || {}, b.extend(v, g), f += 1, i.latestID = "ngdialog" + f;
                        var w;
                        k[i.latestID] = w = n.defer();
                        var x, y, z = b.isObject(v.scope) ? v.scope.$new() : p.$new();
                        return n.when(h(v.template)).then(function (c) {
                            return c = b.isString(c) ? c : c.data && b.isString(c.data) ? c.data : "", l.put(v.template, c), v.showClose && (c += '<div class="ngdialog-close"></div>'), i.$result = x = d('<div name="' + v.name + '" id="ngdialog' + f + '" class="ngdialog"></div>'), x.html('<div class="ngdialog-overlay"></div><div class="ngdialog-content">' + c + "</div>"), v.controller && b.isString(v.controller) && x.attr("ng-controller", v.controller), v.className && x.addClass(v.className), v.data && b.isString(v.data) && (z.ngDialogData = "{" === v.data.replace(/^\s*/, "")[0] ? b.fromJson(v.data) : v.data), y = v.appendTo && b.isString(v.appendTo) ? b.element(document.querySelector(v.appendTo)) : s, z.closeThisDialog = function () {
                                t.closeDialog(x)
                            }, q(function () {
                                m(x)(z);
                                var a = r.innerWidth - s.prop("clientWidth");
                                s.addClass("ngdialog-open");
                                var b = a - (r.innerWidth - s.prop("clientWidth"));
                                b > 0 && t.setBodyPadding(b), y.append(x), p.$broadcast("ngDialog.opened", x)
                            }), v.closeByEscape && s.bind("keydown", t.onDocumentKeydown), e = function (a) {
                                var b = v.closeByDocument ? d(a.target).hasClass("ngdialog-overlay") : !1,
                                    c = d(a.target).hasClass("ngdialog-close");
                                (b || c) && u.close(x.attr("id"))
                            }, "undefined" != typeof a.Hammer ? a.Hammer(x[0]).on("tap", e) : x.bind("click", e), j += 1, u
                        }), {
                            id: "ngdialog" + f,
                            closePromise: w.promise,
                            close: function () {
                                t.closeDialog(x)
                            }
                        }
                    },
                    openConfirm: function (a) {
                        var c = n.defer(),
                            d = {
                                closeByEscape: !1,
                                closeByDocument: !1
                            };
                        b.extend(d, a), d.scope = b.isObject(d.scope) ? d.scope.$new() : p.$new(), d.scope.confirm = function (a) {
                            c.resolve(a), e.close()
                        };
                        var e = u.open(d);
                        return e.closePromise.then(function () {
                            c.reject()
                        }), c.promise
                    },
                    close: function (a) {
                        var b = d(document.getElementById(a));
                        return b.length ? t.closeDialog(b) : u.closeAll(), u
                    },
                    closeAll: function () {
                        var a = document.querySelectorAll(".ngdialog");
                        b.forEach(a, function (a) {
                            t.closeDialog(d(a))
                        })
                    }
                };
            return u
        }]
    }), c.directive("ngDialog", ["ngDialog", function (a) {
        return {
            restrict: "A",
            scope: {
                ngDialogScope: "="
            },
            link: function (c, d, e) {
                d.on("click", function (d) {
                    d.preventDefault();
                    var f = b.isDefined(c.ngDialogScope) ? c.ngDialogScope : "noScope";
                    b.isDefined(e.ngDialogClosePrevious) && a.close(e.ngDialogClosePrevious), a.open({
                        template: e.ngDialog,
                        className: e.ngDialogClass,
                        controller: e.ngDialogController,
                        scope: f,
                        data: e.ngDialogData,
                        showClose: "false" === e.ngDialogShowClose ? !1 : !0,
                        closeByDocument: "false" === e.ngDialogCloseByDocument ? !1 : !0,
                        closeByEscape: "false" === e.ngDialogCloseByEscape ? !1 : !0
                    })
                })
            }
        }
    }])
}(window, window.angular);